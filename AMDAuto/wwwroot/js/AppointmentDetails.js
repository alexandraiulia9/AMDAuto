$(document).ready(function () {
    $('#AddCarPart').on('click', function () {
        let carPartId = $('#partDropdown').val();
        let appointmentId = $('#appointmentId').text();

        if (carPartId != null) {

            if (confirm('Are you sure you want to add this car part to the appointment operation? ')) {
                $.post(Router.action("CarPart", "AddCarPart", { carPartId: carPartId, appointmentId: appointmentId }))
                    .done(function () {
                        location.reload();
                    })
                    .fail(function () {
                        alert("an error has occured!");
                    });
            }
        }

        else {
            alert('You must select a car part!');
        }
    })


    $('.deleteButton').on('click', function (e) {
        let $target = $(e.target);
        let carPartId = $target.data('carpart-id');
        alert(carPartId);
        let appointmentId = $('#appointmentId').text();

        if (carPartId != null) {
            if (confirm('Sigur vreti sa stergeti o piesa?')) {
                $.post(Router.action("CarPart", "DeleteCarPartFromAppointment", { carPartId: carPartId, appointmentId: appointmentId }))
                    .done(function () {
                        location.reload();
                    })
                    .fail(function () {
                        alert("an error has occured!");
                    });
            }
        }
    });
})
