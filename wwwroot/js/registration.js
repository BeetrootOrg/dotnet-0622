const signUpBtn = document.getElementById("signUp");
const usernameField = document.getElementById("username");
const passwordField = document.getElementById("password");

signUpBtn.onclick = async (event) => {
	event.preventDefault();

	const username = usernameField.value;
	const password = passwordField.value;

	const response = await fetch(`/registration`, {
		method: 'POST',
		body: JSON.stringify({
			username,
			password
		}),
		headers: {
			'content-type': 'application/json'
		}
	});

	if (!response.ok) {
		// analog:
		// throw new Error('status code is ' + response.status);
		throw new Error(`status code is ${response.status}`);
	}

	window.location.href = '/login.html';
}