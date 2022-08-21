const clickMeDiv = document.getElementById('click-me');
const clickMe = document.querySelector('#click-me button');
clickMe.addEventListener("click", () =>
    {   
        alert("Congrads! You did it! Tell me how))");
    });

clickMe.addEventListener("mouseover", (ev) =>
{   
    let currentAlign = clickMeDiv.style.textAlign;

    if(currentAlign === 'left')
        clickMeDiv.style.textAlign = 'right';
    else 
        clickMeDiv.style.textAlign = 'left';
})

window.addEventListener('keydown', (event) => {
    if (event.keyCode === 13) {
        event.preventDefault();
        alert("Don't cheat! Enter is disabled");
        return false;
    }

});