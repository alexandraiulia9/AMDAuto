$(document).ready(function () {
    $('.deleteCar').on('click', function (e) {
        let $target = $(e.target);
        let id = $target.data('car-id');
        if (confirm('Sunteti sigur ca doriti sa stergeti masina?')) {
            $.post(Router.action("Cars", "DeleteCar", { id: id }))
                .done(manageResult)
                .fail(function () {
                    alert("Masina nu se poate sterge deoarece are programari efectuate!");
                });
        }
    });

    function manageResult(result) {
        if (result === "Error") {
            alert("Masina nu se poate sterge deoarece are programari efectuate!");
        }
        location.reload();
    }
});