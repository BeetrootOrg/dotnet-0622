(async () => {
	const response = await fetch("me", {
		redirect: 'manual'
	});

	if (response.type === 'opaqueredirect') {
		window.location.href = 'me'
	}
})();