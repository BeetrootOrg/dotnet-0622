const nameInput = document.getElementById("name");
const themeInput = document.getElementById("theme");
const questionInput = document.getElementById("question");
const askButton = document.getElementById("ask-button");

askButton.addEventListener('click', () => {
    const name = nameInput.value;
    const theme = themeInput.options[themeInput.selectedIndex].text;
    const question = questionInput.value;

    const request = {name, theme, question};
    const serialized = JSON.stringify(request);
	localStorage.setItem('request', serialized);
})