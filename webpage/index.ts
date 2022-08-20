const makeCounterTs = () => {
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

const counter1 = makeCounterTs();
const counter2 = makeCounterTs();

counter1.increment();
counter1.increment();
counter2.decrement();

console.log(`Counter1 = ${counter1.value}`); // 2
console.log(`Counter2 = ${counter2.value}`); // -1
