var urlCDNChattingKu = "chattingku.apphb.com";
var chattingHub;
var name = "";
var email = "";

var loadScriptHub = function () {
    var lc_2 = document.createElement('script'); lc_2.type = 'text/javascript'; lc_2.async = true;
    lc_2.src = 'http://' + urlCDNChattingKu + '/Scripts/jquery.signalR-1.1.3.min.js';
    var s_2 = document.getElementsByTagName('script')[0]; s_2.parentNode.insertBefore(lc_2, s_2);

    var lc_1 = document.createElement('script'); lc_1.type = 'text/javascript'; lc_1.async = true;
    lc_1.src = 'http://' + urlCDNChattingKu + '/signalr/hubs';
    var s_1 = document.getElementsByTagName('script')[0]; s_1.parentNode.insertBefore(lc_1, s_1);
};

var connectingToHub = function () {
    $.connection.hub.url = "http://" + urlCDNChattingKu + "/signalr";
    chattingHub = $.connection.chattingKu;
    chattingHub.client.newMessage = newMessage;
    chattingHub.client.showErrorMessage = showErrorMessage;
    $.connection.hub.start().done(function () {
        chattingHub.server.registerHub(__lc.license, name).done(function (result) {
            $(document.body).html("<form id='formChatting'><input type='text' id='message'/><button type='submit'>Send</button></form><div><table id='list-view'></table></div>");
            $("#formChatting").submit(sendMessage);
        }).fail(function (error) {
            console.log(error);
        });
    });
};

var createFormChatting = function () {
    $(document.body).append("<button id='mychatting-btn'>Chat</button>");
};

var sendMessage = function (ev) {
    ev.preventDefault();
    var msg = $('#message').val();
    chattingHub.invoke('Send', __lc.license, name, msg, new Date());
    $('#message').val('').focus();
};

var newMessage = function (data) {
    $("#list-view").append("<tr><td>" + data.UserName + "</td><td>:</td><td>" + data.Message + "</td></tr>");
};

var showErrorMessage = function (error) {
    alert(error);
};

$(function () {
    loadScriptHub();
    //connectingToHub();
    createFormChatting();

    $("#mychatting-btn").click(function () {
        $(document.body).html("<form id='form-input-profile'><div>Nama : <input type='text' id='username' required/> <br/> Email : <input type='email' id='email' required/><br/> <input type='submit'/></div></form>");
        $("#form-input-profile").submit(function (ev) {
            ev.preventDefault();
            name = $("#username").val();
            email = $("#email").val();
            connectingToHub();
        });
    });
});