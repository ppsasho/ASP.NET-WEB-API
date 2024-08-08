
let notesList = document.getElementById("list");
let notesField = document.getElementById("noteField");
let newNoteBtn = document.getElementById("newNoteBtn");
let allNotesBtn = document.getElementById("allNotesBtn");
let port = "7161";
let url = `https://localhost:${port}/api/notes`;

let GetAllNotes = async () => {
    notesField.innerHTML = "";
    notesList.innerHTML = "";

    let notesUrl = `${url}/static-notes`;

    let notes = await fetch(notesUrl);
    let parsedNotes = await notes.json();
    console.log(parsedNotes);

    for (let i = 0; i < parsedNotes.length; i++) {
        let note = document.createElement("li");
        note.innerHTML = parsedNotes[i];
        notesList.appendChild(note);
    }
}

let AddNewNote = async () => {
    let response = await fetch(url, {
        method: "POST",
        headers: {
            "Content-Type": "text/plain"
        },
        body: notesField.value
    });

    let data = await response.text();
    console.log(data);

    notesField.value = "";
    GetAllNotes();
    
}

allNotesBtn.addEventListener("click", GetAllNotes);
newNoteBtn.addEventListener("click", AddNewNote);

