const rootDiv = document.getElementById('root');

fetch('/api/posts')
	.then(response => response.json())
	.then(result => {
		result.forEach(post => {
			const block = document.createElement('div');
			const img = document.createElement('img');
			const header = document.createElement('h3');
			const description = document.createElement('p');

			img.src = post.imageUrl;
			header.innerText = post.caption;
			description.innerText = post.description;

			block.appendChild(img);
			block.appendChild(header);
			block.appendChild(description);

			rootDiv.appendChild(block);
		})
	})