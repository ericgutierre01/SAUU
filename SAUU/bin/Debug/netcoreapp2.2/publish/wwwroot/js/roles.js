
$(document).ready(function () {
    $("#perAcciones").select2({
        placeholder: "Seleccione"
    });

    $("#addPermission").click(function (e) {
        $("p").html("");
        var perId = $("#perId option:selected").val();
        var perRestricciones = $("#perAcciones").val();
        if (!perId.length) {
            $("p").html("Debe seleccionar un permiso");
            return;
        }
        var restricciones = "";
        for (var x = 0; x < perRestricciones.length; x++) {
            restricciones += perRestricciones[x] + ",";
        }

        $("table tbody").append(`
            <tr>
                <td></td>
                <td>` + perId + `</td>
                <td>` + $("#perId option:selected").text() + `</td>
                <td>` + restricciones + `</td>
            </tr>`);

    });
});