document.querySelector("#login .btn").onclick = async function () {
    var user = {
        username: document.querySelector("#login #username").value,
        password: document.querySelector("#login #password").value
    };

    var response = await window.fetch('/Login/login', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json;'
        },
        body: JSON.stringify(user)
    });

    if (response.ok) {
        document.querySelector("#login .alert").classList.add("alert-success");
        document.querySelector("#login .alert").classList.toggle("invisible");
        document.querySelector("#login .alert i").classList.add("bi-check-circle-fill")
        document.querySelector("#login .alert span").innerText = "Inloggningen lyckades!"
    } else {
        document.querySelector("#login .alert").classList.add("alert-warning");
        document.querySelector("#login .alert").classList.toggle("invisible");
        document.querySelector("#login .alert i").classList.add("bi-exclamation-triangle-fill")
        document.querySelector("#login .alert span").innerText = "Inloggningen misslyckades!"
    }
}

document.querySelector("#register .btn").onclick = async function () {
    var user = {
        username: document.querySelector("#register #username").value,
        password: document.querySelector("#register #password").value
    };

    var response = await window.fetch('/register/RegisterUser', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json;'
        },
        body: JSON.stringify(user)
    });

    if (response.ok) {
        document.querySelector("#register .alert").classList.add("alert-success");
        document.querySelector("#register .alert").classList.toggle("invisible");
        document.querySelector("#register .alert i").classList.add("bi-check-circle-fill")
        document.querySelector("#register .alert span").innerText = "Inloggningen lyckades!"
    } else {
        document.querySelector("#register .alert").classList.add("alert-warning");
        document.querySelector("#register .alert").classList.toggle("invisible");
        document.querySelector("#register .alert i").classList.add("bi-exclamation-triangle-fill")
        document.querySelector("#register .alert span").innerText = "Registreringen misslyckades!"
    }
}