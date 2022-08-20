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

// analogue below
// function makeCounter() {}
// const makeCounter = function() {}
const makeCounter = () => {
	let counter = 0;
	return {
		increment() {
			++counter;
		},
		decrement() {
			--counter;
		},
		get value() {
			return counter;
		}
	}
};

const counter1 = makeCounter();
const counter2 = makeCounter();

counter1.increment();
counter1.increment();
counter2.decrement();

console.log(`Counter1 = ${counter1.value}`); // 2
console.log(`Counter2 = ${counter2.value}`); // -1

let counter = 0;
const makeCounterGlobal = () => {
	return {
		increment() {
			++counter;
		},
		decrement() {
			--counter;
		},
		get value() {
			return counter;
		}
	}
};

const globalCounter1 = makeCounterGlobal();
const globalCounter2 = makeCounterGlobal();

globalCounter1.increment();
globalCounter1.increment();
globalCounter2.decrement();

console.log(`GlobalCounter1 = ${globalCounter1.value}`); // 1
console.log(`GlobalCounter2 = ${globalCounter2.value}`); // 1
