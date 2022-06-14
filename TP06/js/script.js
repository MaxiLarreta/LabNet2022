$(document).ready(function(){

   
    let formData = {
        Nombre: "",
        Apellido: "",
        Nacimiento: "",
        Edad: "",
        Genero: "",
        Empresa: ""
    };

    const inputs = document.querySelectorAll("input")
    const p = document.querySelectorAll("p")
   
    $('input').on('keyup change', function() {
        this.name === "Nacimiento" ? formData[this.name] = `${this.valueAsDate.getDate()}/${this.valueAsDate.getMonth()}/${this.valueAsDate.getFullYear()}` : 
        this.name === "Genero" && this.checked === true || this.name !== "Genero" ? formData[this.name] = this.value : null;
     });
     
     
    const calcAge = (date) => date === null ? "" : Math.floor((Date.now() - date) / (31557600000));

    $("#nacimiento").change((e) => {
        let edad = calcAge(e.target.valueAsDate);
        $("#edad")[0].value = edad;
        formData.Edad = edad;
    })

    $(".clear").click((e) => {
        e.preventDefault()

        formData = {
            Nombre: "",
            Apellido: "",
            Nacimiento: "",
            Edad: "",
            Genero: "",
            Empresa: ""
        };
        inputs.forEach((e) => e.value = "");
    })
    $("form").submit((e) => {
        e.preventDefault()
    })
    
    $("form").validate({
        rules: {
            Nombre : {
                required: true,
                minlength: 2
            },
            Apellido : {
                required: true,
                minlength: 2
            },
            Nacimiento : {
                required: true
            },
            Edad : {
                min: 18,
                max: 150
            }
        },

        messages : {
            Nombre : {
                required: "Ingrese el nombre",
                minlength: "El nombre debe tener al menos 2 caracteres"
            },
            Apellido : {
                required: "Ingrese el apellido",
                minlength: "El apellido debe tener al menos 2 caracteres"
            },
            Nacimiento : {
                required: "Debe ingresar una fecha de nacimiento"
            },
            Edad : {
                min: "Debe ser mayor de 18 años",
                max: "Por favor ingrese una edad válida"
            }
        },

        submitHandler: function(form) {
            let data = Object.values(formData);
            $('.principalSection').addClass("hide")
            p.forEach((p, i) => {p.innerHTML = data[i]})
            $('#information').removeClass("hide")
        }
    });

    $(".ok").click(() =>{
        $('#information').addClass("hide")
        $('.principalSection').removeClass("hide")

    }
    )

  });

  
 