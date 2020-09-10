$(document).ready(function () {
    $('.TakeAppointment').on('click', function (e) {
        let $target = $(e.target);
        let id = $target.data('appointment-id');
        if (confirm('Sunteti sigur ca doriti sa va atribuiti aceasta programare?')) {
            $.post(Router.action("Appointment", "TakeAppointment", { id: id }))
                .done(function () {
                    location.reload();
                })
                .fail(function () {
                    alert("Eroare!")
                });
        }
    });
});