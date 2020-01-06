$(document).ready(function () {
    $("#CiuId").change(function () {
        if ($("#CiuIdPostal").val().includes("Seleccione")) {
            $("#CiuIdPostal").val(this.value);
            cargarPueblos(this.value, '#PueIdPostal');
        }
    });

    $("#PueId").change(function () {
        if ($("#PueIdPostal").val().includes("Seleccione")) {
            $("#PueIdPostal").val(this.value);
        }
    });

    $("#EstDireccion").blur(function () {
        if ($("#EstDireccionPostal").val().length === 0) {
            $("#EstDireccionPostal").val(this.value);
        }
    });

    $("#EstCodigoPostal").blur(function () {
        if ($("#EstCodigoPostalPostal").val().length === 0) {
            $("#EstCodigoPostalPostal").val(this.value);
        }
    });


    $("#copiarTutor").click(function () {
        $("#Tutores_1__ParId").val($("#Tutores_0__ParId").val());
        $("#Tutores_1__ParNombres").val($("#Tutores_0__ParNombres").val());
        $("#Tutores_1__ParApellidos").val($("#Tutores_0__ParApellidos").val());
        $("#Tutores_1__ParSeguroSocial").val($("#Tutores_0__ParSeguroSocial").val());
        $("#Tutores_1__ParDireccion").val($("#Tutores_0__ParDireccion").val());
        $("#Tutores_1__ParTelefonoRes").val($("#Tutores_0__ParTelefonoRes").val());
        $("#Tutores_1__ParTelefonoMovil").val($("#Tutores_0__ParTelefonoMovil").val());
        $("#Tutores_1__ParTelefonoISP").val($("#Tutores_0__ParTelefonoISP").val());
        $("#Tutores_1__ParLugarTrabajo").val($("#Tutores_0__ParLugarTrabajo").val());
        $("#Tutores_1__ParTelefonoTrabajo").val($("#Tutores_0__ParTelefonoTrabajo").val());
        $("#Tutores_1__ParOcupacion").val($("#Tutores_0__ParOcupacion").val());
        $("#Tutores_1__ParEmail").val($("#Tutores_0__ParEmail").val());
        $("#Tutores_1__ParDatos1").val($("#Tutores_0__ParDatos1").val());
    });

    $("#copiarTutor2").click(function () {
        $("div#bs-tabdrop-tab2").append(`
            <fieldset>
                <legend> Información Segundo Tutor</legend >
                <div class="col-md-2"><div class="control-group">
                    <label>Parentesco</label>
                    <select class="form-control form-group-margin" name="Tutores_0__ParId">
                        <option>- Seleccione -</option>
                    </select>
                </div>
            </fieldset>`);
        $(this).parent().remove();
    });


    //Calcular la edad en base a la fecha Nacimiento.
    $("#EstFechaNacimiento").blur(function () {
        var years = dateDiffYear($("#EstFechaNacimiento").val());
        $("#edad").val(years);
    });

    $("#EstFechaNacimiento").blur();
});