$("#getNews").click(function () {
    var host = "http://localhost:20778/";
    var url = host + 'api/News/GetAll';
    const table = document.getElementById("Table");
    $.ajax({
        type: "GET",
        url: url,
        contentType: "application/json",
        dataType: "json",
        success: function (data) {
            for (var i = 0; i < data.length; i++) {
                table.innerHTML += `
                <tr><td>${data[i].id}</td><td>${data[i].title}</td><td>${data[i].text}</td><td>${data[i].imageName}</td><td>${data[i].image}</td><td>${data[i].link}</td><td>${data[i].date}</td></tr> `
            }
        }
    });
});

$(document).ready(function () {
})
