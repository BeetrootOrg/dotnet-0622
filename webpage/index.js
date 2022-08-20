console.log('Hello, world');

const clicker = document.getElementById('clicker');
clicker.addEventListener('click', (ev) => {
	console.log(ev);
});

const clickerButton = document.querySelector('#counter button');
const clickerText = document.querySelector('#counter p');

let countClicks = 0;
clickerButton.addEventListener('click', () => {
	// analogue below
	// clickerText.innerHTML = 'Clicks: ' + ++countClicks;
	clickerText.innerHTML = `Clicks: ${++countClicks}`;
});