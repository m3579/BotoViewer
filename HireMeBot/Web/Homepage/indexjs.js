$(document).ready(function () {
    // Hide the characteristics at first (until the user presses
    // a button)
    toggleCharacteristics();

    // Get the list of characteristics that the employer can select from
    // from the server
    $.get("/api/employer/characteristics", {}, function (characteristics) {

        // Put them in a form
        $.each(characteristics, function (key, value) {
            $("#characteristics form").append("<input type='radio' name='characteristics' value='" + value + "' />" + value + "<br>");
        });
    });
});

function toggleCharacteristics()
{
    if ($("#characteristics").is(":visible")) {
        $("#characteristics").hide("slide", { direction: "up" }, 750);
    }
    else {
        $("#characteristics").show("slide", { direction: "up" }, 750);
    }
}

function sendCharacteristics()
{
    var characteristics = $("input");

    var selectedCharstcs = [];

    $.each(characteristics, function (key, value) {
        if (value.checked == true) {
            selectedCharstcs.push(value.value);
        }
    });
    
    alert(selectedCharstcs);

    $.post("/api/employer/characteristics", {
        selectedCharstcs
    });
}