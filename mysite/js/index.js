const emailInput = document.querySelector("#registerForm #email");
const passwordInput = document.querySelector("#registerForm #password");
const submitBtn = document.querySelector("#registerForm #submitbutton");
const registrationTable = document.querySelector(" #registrations");


const renderRegistrations = () => {
    const serialized  = localStorage.getItem('registration');
    const registration = JSON.parse(serialized);

    const tr = document.createElement('tr');
    const emailData = document.createElement('td');
    emailData.innerText = registration.email;
    const passwordData = document.createElement('td');
    passwordData.innerText = registration.password;
    tr.appendChild(emailData);
    tr.appendChild(passwordData);

}


submitBtn.addEventListener('click', (e) => {
    e.preventDefault();
    console.log(emailInput.value);
    console.log(passwordInput.value);
    const email = emailInput.value;
    const password = passwordInput.value;

    const registration = (email, password);
    const serializated = JSON.stringify(registration);
    localStorage.setItem('registration', serializated);
});