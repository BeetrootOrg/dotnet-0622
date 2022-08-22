const emailInput = document.querySelector("#registerForm #email");
const passwordInput = document.querySelector("#registerForm #password");
const submitBtn = document.querySelector("#registerForm #submit");
const registrationsTableBody = document.querySelector("#registrations tbody");

const getRegistrations = () => {
	const serialized = localStorage.getItem('registration');
	return JSON.parse(serialized) || [];
};

const setRegistrations = (registrations) => {
	const serialized = JSON.stringify(registrations);
	localStorage.setItem('registration', serialized);
};

const renderRegistrations = () => {
	registrationsTableBody.innerHTML = '';
	getRegistrations().forEach((registration) => {
		const tr = document.createElement('tr');

		const emailData = document.createElement('td');
		emailData.innerText = registration.email;

		const passwordData = document.createElement('td');
		passwordData.innerText = registration.password;

		const deleteButton = document.createElement('button');
		deleteButton.innerText = 'Delete';
		deleteButton.className = 'btn btn-outline-danger';
		deleteButton.onclick = () => {
			const registrations = getRegistrations();
			setRegistrations(registrations
				.filter((element) => !(element.email === registration.email &&
					element.password === registration.password)));

			renderRegistrations();
		};

		const deleteData = document.createElement('td');
		deleteData.appendChild(deleteButton);

		tr.appendChild(emailData);
		tr.appendChild(passwordData);
		tr.appendChild(deleteData);

		registrationsTableBody.appendChild(tr);
	});
}

submitBtn.addEventListener('click', (e) => {
	e.preventDefault();

	const email = emailInput.value;
	const password = passwordInput.value;

	const oldRegistrations = getRegistrations();
	const registration = { email, password };
	setRegistrations([...oldRegistrations, registration])

	renderRegistrations();
});

renderRegistrations();