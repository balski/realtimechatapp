function delay(e) {
	return new Promise((n => setTimeout(n, e)))
}

delay(3e3).then((() => alert("runs after 3 seconds")));