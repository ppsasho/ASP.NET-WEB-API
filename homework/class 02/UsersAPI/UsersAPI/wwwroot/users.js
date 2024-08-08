let findUserBtn = document.getElementById("findUserBtn");
let createUserBtn = document.getElementById("createUserBtn");
let getAllUsersBtn = document.getElementById("getAllUsersBtn");
let userIdField = document.getElementById("userIdField");
let usernameField = document.getElementById("usernameField");
let userList = document.getElementById("userList");

let port = "7159";
let url = `https://localhost:${port}/api/users`;

let getAllUsers = async () => {
    userList.innerHTML = "";
    let allUrl = `${url}/all`;

    let result = await fetch(allUrl);
    console.log(result);

    let usersList = await result.json();
    console.log(usersList);

    usersList.forEach(x => {
        let user = document.createElement("li");
        user.classList.add("list-group-item");
        user.innerText = `[${x.username} | id: ${x.id}]`;

        userList.appendChild(user);
    })
}

let getUserById = async () => {
    userList.innerHTML = "";
    if (userIdField.value === "") {
        alert("Please enter an Id first!");
        return;
    }
    let idUrl = `${url}/${userIdField.value}`;
    userIdField.value = "";

    try {
        let result = await fetch(idUrl);
        let user = await result.json();
        console.log(user);

        let item = document.createElement("li");
        item.classList.add("list-group-item");
        item.innerText = `[${user.username} | id: ${user.id}]`;
        userList.appendChild(item);
    } catch(e) {
        alert(`This is most likely a nonexistent or invalid id!:\n ${e}`);
        return;
    }
    
}

let createUser = async () => {
    if (usernameField.value === "") {
        alert("Please enter a username first!");
        return;
    }

    let user = {
        username: usernameField.value
    }
    usernameField.value = "";

    let result = await fetch(url, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(user)
    });

    getAllUsers();
}

createUserBtn.addEventListener("click", createUser);
findUserBtn.addEventListener("click", getUserById);
getAllUsersBtn.addEventListener("click", getAllUsers);