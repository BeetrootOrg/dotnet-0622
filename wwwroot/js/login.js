const signInBtn = document.getElementById("signIn");
const usernameField = document.getElementById("username");
const passwordField = document.getElementById("password");

signInBtn.onclick = async (event) => {
	event.preventDefault();

	const username = usernameField.value;
	const password = passwordField.value;

	const queryParams = new Proxy(new URLSearchParams(window.location.search), {
		get: (searchParams, prop) => searchParams.get(prop),
	});
	let returnUrl = queryParams.returnUrl || '';

	const response = await fetch(`/sign-in?returnUrl=${returnUrl}`, {
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

	window.location.href = returnUrl;
}