(async () => {
	const response = await fetch("me");

	if (response.status === 401) {
		window.location.href = `/login.html?returnUrl=${encodeURIComponent(window.location.href)}`
	}
})();