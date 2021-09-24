
//import { signalR } from "../lib/signalr/dist/browser/signalr";


var connection = new signalR.HubConnectionBuilder().withUrl("/notifikacijahub").build();

connection.on("prijemNotifikacije", function (message) {
    let div = document.createElement("div");
    div.className = "notifikacija-alert";
    $("body").append(div);

    let notifikacija = $(".notifikacija-alert");    
    notifikacija.html(message);
    notifikacija.fadeIn();
    notifikacija.delay(8000).fadeOut(300);

});

connection.start().then(function () {
    console.info("SignalR radi");
}).catch(function (err) {
    return console.info("Error je " + err.toString());
});