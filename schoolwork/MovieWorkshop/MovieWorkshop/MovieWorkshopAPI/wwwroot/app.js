
fetch("")

const headers = {'Authorization': 'Bearer'}

fetch("https://localhost:7265/api/Movies")
.then(res => res.json())
.then(movies => {
    console.log(movies);
})
.catch(err => {
    console.log(err);
})