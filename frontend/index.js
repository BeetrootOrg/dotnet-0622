console.log("Hello, world!");

(async () => {
	const response = await fetch('https://localhost:7146/WeatherForecast');
	const result = await response.json()
	console.log(result);
})()