document.getElementById('dog-button').addEventListener('click', function () {
    fetch('/Home/GetDogImage')
        .then(response => response.json())
        .then(data => {
            document.getElementById('animal-image').src = data.url;
        })
        .catch(error => {
            console.error('Erro ao buscar a imagem de cachorro:', error);
        });
});

document.getElementById('cat-button').addEventListener('click', function () {
    fetch('/Home/GetCatImage')
        .then(response => response.json())
        .then(data => {
            document.getElementById('animal-image').src = data.url;
        })
        .catch(error => {
            console.error('Erro ao buscar a imagem de gato:', error);
        });
});