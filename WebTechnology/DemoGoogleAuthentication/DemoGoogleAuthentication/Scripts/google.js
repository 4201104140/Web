var auth2;
var user = {};
var googleUserr = {};
var initClient = function () {
    gapi.load('auth2', function () {

        auth2 = gapi.auth2.init({
            client_id: '407576620147-2d11d7hvqc3fnudniv4q6hag23uftqk6.apps.googleusercontent.com'
        });

        auth2.attachClickHandler('g-signin2', {}, onSuccess, onFailure);
    });
}

function onSuccess(googleUser) {
    var profile = googleUser.getBasicProfile();
    googleUserr = googleUser;
    debugger;
    user.Id = profile.getId();
    user.Username = profile.getName();
    user.Email = profile.getEmail();
    user.AccessToken = "";
    user.ImageUrl = profile.getImageUrl();
    token = auth2.currentUser.get().Zi.access_token;
    sendData(user);
    console.log('Logged in as: ' + googleUser.getBasicProfile().getName());
}
function onFailure(error) {
    console.log(error);
}

function sendData(user) {
    const url = "https://localhost:44367/Login/Index";
    fetch(url, {
        method: 'POST',
        headers: {
            'Content-type': 'application/json'
        },
        body: JSON.stringify({
            user: {
                Id: user.Id,
                Username: user.Username,
                Email: user.Email,
                AccessToken: user.AccessToken,
                ImageUrl: user.ImageUrl
            }
        })
    }).then(
        response => response.text()
    ).then(
        html => location.reload()
    );
}
var token;

function grantScope() {
    var options = new gapi.auth2.SigninOptionsBuilder(
        {
            'scope': 'email https://www.googleapis.com/auth/drive https://www.googleapis.com/auth/drive.file https://www.googleapis.com/auth/drive.readonly https://www.googleapis.com/auth/drive.metadata.readonly https://www.googleapis.com/auth/drive.appdata https://www.googleapis.com/auth/drive.metadata https://www.googleapis.com/auth/drive.photos.readonly'
        });
    googleUserr = auth2.currentUser.get();
    googleUserr.grant(options).then(
        function (success) {
            token = success.Zi["access_token"];
        },
        function (fail) {
            alert(JSON.stringify({ message: "fail", value: fail }));
        }
    )
}

function getFolder() {
    var xhr = new XMLHttpRequest();
    xhr.withCredentials = true;

    xhr.open("GET", "https://www.googleapis.com/drive/v3/files?corpora=user&includeItemsFromAllDrives=true&q=mimeType%20%3D%20'application%2Fvnd.google-apps.folder'&supportsAllDrives=true");
    xhr.setRequestHeader("content-type", "application/json");
    xhr.setRequestHeader("authorization", "Bearer " + token);
    xhr.setRequestHeader("cache-control", "no-cache");

    xhr.send();
    xhr.addEventListener("readystatechange", function () {
        debugger;
        if (this.readyState === 4) {
            result = this.responseText;
            showName(result);
        }
    });

};
function showName() {
    if (result != null) {
        var data = JSON.parse(result);
        if (data["error"]) {
            alert("Bạn không có quyền này.")
        }
        else {
            var data = JSON.parse(result)["files"];
            var ul = document.getElementById("list-folder");
            var li = document.createElement("li");
            li.className = "list-group-item";
            li.appendChild(document.createTextNode('Folders'));
            ul.appendChild(li);
            data.forEach(function (v) {
                li = document.createElement("li");
                li.className = "list-group-item";
                li.appendChild(document.createTextNode(v["name"]));
                ul.appendChild(li);
            })
        }
        
    }
}

function SignOut() {
    auth2.disconnect();
    location.href = "/Login/SignOut";
}