$("#getBigPara2").click(function () {
    var host = "http://localhost:20778/";
    var url = host + 'api/BigPara/AllBigPara';
    const table = document.getElementById("Table");
    $.ajax({
        type: "GET",
        url: url,
        contentType: "application/json",
        dataType: "json",
        success: function (data) {
            for (var i = 0; i < data.length; i++) {
                table.innerHTML += `
        
                <tr><td>${data[i].id}</td><td>${data[i].title}</td><td>${data[i].spot}</td><td>${data[i].description}</td><td>${data[i].link}</td><td>${data[i].imagePath}</td><td>${data[i].category}</td><td>${data[i].orderr}</td></tr> `
            }
        }
    });
});

$(document).ready(function () {
})
