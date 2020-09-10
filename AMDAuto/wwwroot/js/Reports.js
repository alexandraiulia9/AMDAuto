$(document).ready(function () {
    $.ajax({
        type: 'GET',
        url: $settings.ClientsAndExperiences,
        success: function (result) {
            $('#loading-clients').remove();
            google.charts.load('current', {
                callback: function () {
                    $("#totalClients").text(result.totalClients);
                    $("#totalExperiences").text(result.totalExperiences);
                    $("#totalPoints").text(result.totalPoints);
                    $("#redeemedPoints").text(result.redeemedPoints);
                    drawClientChart(result.clientsExperiences);
                    drawPointsChart(result.pointsChart);
                },
                packages: ['corechart', 'gauge']
            });

        },
        error: function (error) {

        }
    });

    function drawClientChart(result) {
        var arr = [[$settings.date, $settings.clients, $settings.vouchers]];

        for (let i = 0; i < result.length; ++i) {
            arr.push([result[i].monthName, result[i].totalClients, result[i].totalExperiences]);
        }

        var data = google.visualization.arrayToDataTable(arr);

        var maxVAxis = Math.max(...result.map(res => res.totalExperiences));

        var options = {
            curveType: 'function',
            legend: { position: 'none' },
            vAxis: {
                textPosition: 'none',
                baselineColor: '#CCCCCC',
                gridlineColor: '#fff',
                viewWindowMode: 'explicit',
                viewWindow: {
                    max: maxVAxis,
                    min: 0
                }
            },
            hAxis: {
                baselineColor: '#ccc',
                gridlineColor: '#ccc'
            },
            colors: ['#f36f21', '#005b8b'],
            pointSize: 10,
            series: {
                0: { pointShape: 'Circle' }
            }
        };

        var chart = new google.visualization.LineChart(document.getElementById('clientsChart'));

        chart.draw(data, options);
    }

    function drawPointsChart(result) {
        var arr = [[$settings.date, $settings.totalPoints, $settings.redeemedPoints]];

        for (let i = 0; i < result.length; ++i) {
            arr.push([result[i].monthName, result[i].totalPoints, result[i].redeemedPoints]);
        }

        var data = google.visualization.arrayToDataTable(arr);

        var maxVAxis = Math.max(...result.map(res => res.totalPoints));

        var options = {
            curveType: 'function',
            legend: { position: 'none' },
            vAxis: {
                textPosition: 'none',
                baselineColor: '#CCCCCC',
                gridlineColor: '#fff',
                viewWindowMode: 'explicit',
                viewWindow: {
                    max: maxVAxis,
                    min: 0
                }
            },
            hAxis: {
                baselineColor: '#ccc',
                gridlineColor: '#ccc'
            },
            colors: ['#0076b4', '#70bd46'],
            pointSize: 10,
            series: {
                0: { pointShape: 'Circle' }
            }
        };

        var chart = new google.visualization.LineChart(document.getElementById('pointsChart'));

        chart.draw(data, options);
    }
});     