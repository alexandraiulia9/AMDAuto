$('.statuses').on("change", function (e) {
    let $target = $(e.target);
    let id = $target.data('appointment-id');
    let value = $target[0].value;
    if (confirm('Are you sure you want to change this status?')) {
        $.post(Router.action("Appointment", "SetStatusByAppointmentId"), { appointmentId: id, statusName: value })
            .done(function () {
                location.reload();
            })
            .fail(function () {
                alert("Eroare!");
            });
    }
})