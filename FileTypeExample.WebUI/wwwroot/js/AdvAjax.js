$("#getAdv").click(function () {
    var host = "http://localhost:20778/";
    var url = host + 'api/Adv/GetAll';
    const table = document.getElementById("Table");
    $.ajax({
        type: "GET",
        url: url,
        contentType: "application/json",
        dataType: "json",
        success: function (data) {
            for (var i = 0; i < data.length; i++) {
                table.innerHTML += `
        
                <tr><td>${data[i].id}</td><td>${data[i].text}</td><td>${data[i].defLink}</td><td>${data[i].location}</td><td>${data[i].price}</td><td>${data[i].title}</td><td>${data[i].cityId}</td><td>${data[i].cityName}</td></tr> `
            }
        }
    });
});

$(document).ready(function () {
})
