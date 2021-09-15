$("#getBigPara").click(function () {
        Bigpara();
});


function Bigpara() {
    var host = "http://localhost:20778/";
    var url = host + 'api/BigPara/AllBigPara';
    const bigparaDiv = document.getElementById("Table");
    fetch(url)
        .then(response => response.json())
        .then(data => {
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                bigparaDiv.innerHTML += `
        
                <tr><td>${ data[i].id}</td><td>${data[i].title}</td><td>${data[i].spot}</td><td>${data[i].description}</td><td>${data[i].link}</td><td>${data[i].imagePath}</td><td>${data[i].category}</td><td>${data[i].orderr}</td></tr> `
            }
        })
}

$(document).ready(function () {
})





////$("#getBigPara").click(function () {
////    debugger;
////    $.ajax({
////        url: "http://localhost:20778/api/BigPara/AllBigPara",
////        type: "get",
////        contentType: "text/json",
////        success: function (result, status, xhr) {
////            $.each(result, function (index, value) {
////                $("tbody").append($("<tr>"));
////                appendElement = $("tbody tr").last();
////                appendElement.append($("<td>").html(value["id"]));
////                appendElement.append($("<td>").html(value["title"]));
////                appendElement.append($("<td>").html(value["spot"]));
////            });
////        },
////        error: function (xhr, status, error) {
////            console.log(xhr)
////        }
////    });
    //$.ajax({
    //    type: "GET",
    //    url: "http://localhost:60499/BigPara/Order",
    //    contentType: "application/json",
    //    dataType: "json",
    //    success: function (data) {
    //            $.each(data, function (index, item) {
    //            //var rows = "<tr>" +
    //            //    "<td id='Id'>" + item.id + "</td>" +
    //            //    "<td id='Title'>" + item.title + "</td>" +
    //            //    "<td id='Spot'>" + item.spot + "</td>" +
    //            //    "</tr>";
    //                $('#dvItems').append("" + item.title+ "");
    //            });
    //    }
    //});
//});
//$("#getBigPara").click(function () {
//	debugger;
//	var myArray = [];
//	$.ajax({
//		method: 'GET',
//		url: 'http://localhost:20778/api/BigPara/AllBigPara',
//		success: function (response) {
//			myArray = response.data
//			buildTable(myArray)
//			console.log(myArray)
//		}
//	});
//});

//function buildTable(data) {
//	var table = document.getElementById('myTable')

//	for (var i = 0; i < data.length; i++) {
//		var row = `<tr>
//							<td>${data[i].id}</td>
//							<td>${data[i].title}</td>
//							<td>${data[i].spot}</td>
//					  </tr>`
//		table.innerHTML += row


//	}
//}

//$("#getBigPara").click(function () {
//    debugger;
//    $.getJSON('/functions.php', { get_param: 'value' }, function (data) {
//        $.each(data, function (index, element) {
//            $('body').append($('<div>', {
//                text: element.name
//            }));
//        });
//    });
//});
