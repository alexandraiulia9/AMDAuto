$(document).ready(function () {
    $.get(Router.action("Dashboard", "GetStatistics"))
        .done(function (result) {
            google.charts.load('current', {
                callback: function () {
                    manageCarParts(result.carParts);
                    manageOperations(result.operations);
                    manageClients(result.clients);
                },
                packages: ['corechart', 'gauge']
            });
        })
        .fail(function () {
            alert("Eroare!");
        });
});

function manageCarParts(result) {
    var arr = [['Nume', 'Cantitate']];
    for (let i = 0; i < result.length; i++) {
        arr.push([result[i].name, result[i].usedQuantity]);
    }
    console.log(arr);

    var data = google.visualization.arrayToDataTable(arr);
    var view = new google.visualization.DataView(data);

    var options = {
        title: 'Cele mai utilizate piese',
        bar: { groupWidth: "95%" }
    };

    var chart = new google.visualization.ColumnChart(document.getElementById('mostCarParts'));
    chart.draw(view, options);
}

function manageOperations(result) {
    var arr = [['Nume', 'Numar']];
    for (let i = 0; i < result.length; i++) {
        arr.push([result[i].name, result[i].usedNumber]);
    }
    console.log(arr);

    var data = google.visualization.arrayToDataTable(arr);

    var options = {
        title: 'Most Operations',
    };

    var chart = new google.visualization.PieChart(document.getElementById('mostOperations'));
    chart.draw(data, options);
}


function manageClients(result) {
    var arr = [['Nume', 'Numar']];
    for (let i = 0; i < result.length; i++) {
        arr.push([result[i].name, result[i].usedNumber]);
    }
    console.log(arr);

    var data = google.visualization.arrayToDataTable(arr);

    var options = {
        title: 'Most Clients',
        pieHole: 0.4,
    };

    var chart = new google.visualization.PieChart(document.getElementById('mostClients'));
    chart.draw(data, options);
}