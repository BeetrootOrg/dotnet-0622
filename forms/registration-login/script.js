const emailInput = document.getElementById("email");
const passwordInput = document.getElementById("password");
const signUpButton = document.getElementById("sign-up");
const signInButton = document.getElementById("sign-in");

const getRegistrations = () => {
	const serialized = localStorage.getItem('registration');
	return JSON.parse(serialized) || [];
};

const setRegistrations = (registrations) => {
	const serialized = JSON.stringify(registrations);
	localStorage.setItem('registration', serialized);
};

signUpButton.addEventListener('click', () => {
    const email = emailInput.value;
    const password = passwordInput.value;

    const registration = {email, password};
    const allUserData = getRegistrations();
    
    allUserData.forEach(data => {
        if (data.email === registration.email)
        {
            alert("User already exist!");
        }
    });
    setRegistrations([...allUserData, registration]);
});

signInButton.addEventListener('click', () => {
    const allUserData = getRegistrations();

    const currentEmail = emailInput.value;
    const currentPassword = passwordInput.value;

    let isSignInSuccess = false;
    allUserData.forEach(data => {
        if (data.email === currentEmail && data.password === currentPassword)
            isSignInSuccess = true;
    });
    if (isSignInSuccess)
        alert("Success!");
    else
        alert("Email or password is wrong!");
});