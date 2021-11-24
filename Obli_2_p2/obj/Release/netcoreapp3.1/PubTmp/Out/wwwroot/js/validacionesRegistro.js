document.querySelector("#idForm1").addEventListener("submit", validarForm);
function validarForm(evento) {
    evento.preventDefault(); // recordatorio, frena el envio del formulario

    let nombre = document.querySelector("#idNombre").value;
    let apellido = document.querySelector("#idApellido").value;
    let correo = document.querySelector("#idCorreo").value;
    let fechaN = document.querySelector("#idFn").value;
    let password = document.querySelector("#idPass").value;
    let nick = convertirAMayusculas(document.querySelector("#idNick").value);


    if (validarLargoNA(nombre, apellido) && ValidarCorreo(correo) && ValidarFN(fechaN) && validarPass(password) && nick != ""){

        this.submit();
       
    } else {
        document.querySelector("#Pmsj").innerHTML = "Verifique los datos";
    }

}
//Convierte un texto "txt" a mayusculas.
//Devuelve el texto convertido.
function convertirAMayusculas(txt) {
    return txt.toUpperCase();
}

//Valida que la pass cumpla lo necesario
function validarPass(pass) {
    let valido = false;
    if (pass != "") {
        if (pass.length >= 6) {
            let numero = false;
            let mayuscula = false;
            let minuscula = false;
            for (let i = 0; i < pass.length; i++) {
                if (!isNaN(pass.charAt(i))) {
                    numero = true;
                }
                if (pass.charCodeAt(i) >= 65 && pass.charCodeAt(i) <= 90) {
                    mayuscula = true;
                }
                if (pass.charCodeAt(i) >= 97 && pass.charCodeAt(i) <= 122) {
                    minuscula = true;
                }
            }
            if (numero && mayuscula && minuscula) {
                valido = true;
            }
        }
    }

    return valido;
}
//Valida el largo del nombre y del apellido
function validarLargoNA(nombre, apellido) {
    valido = false;
    if (nombre.length >= 2 && apellido.length >= 2) {
        valido = true;
    }
    return valido;
}

//Valida que el correo contenga un @ y un .
function ValidarCorreo(correo) {
    valido = false;
    posicionArr = 0;
    if (correo != "") {
        let arr = false;
        let punto = false;
        
        for (var i = 0; i < correo.length; i++) {
            if (correo.charAt(i) === "@") {
                arr = true;
                posicionArr = i;
            }
            
        }
        if (correo.includes(".", posicionArr)) {
            punto = true;
        }
        
        if (arr && punto ) {
            valido = true;
        }
        return valido;
    }
    
}
//Validar fecha Nacimiento
    function ValidarFN(fecha) {
        valido = false;
        if (fecha != "") {
            if (fecha < Date.now) {
                valido = true;
            }
        }
        return valido;
}

