document.querySelector("#login .btn").onclick = async function () {
    var user = {
        username: document.querySelector("#login #username").value,
        password: document.querySelector("#login #password").value
    };

    var response = await window.fetch(`/Login/login?username=${user.username}&password=${user.password}`);

    if (response.ok) {
        document.querySelector("#login .alert.alert-success").classList.remove("invisible");
        document.querySelector("#login .alert.alert-warning").classList.add("invisible");
    } else {
        document.querySelector("#login .alert.alert-success").classList.add("invisible");
        document.querySelector("#login .alert.alert-warning").classList.remove("invisible");
    }
}