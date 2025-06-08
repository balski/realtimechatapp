function wordFrequency(text) {
	const cleanedText = text.toLowerCase().replace(/[^\w\s]/g, '');

	const words = cleanedText.split(/\s+/);

	const frequency = {};
	for (let word of words) {
		frequency[word] = (frequency[word] || 0) + 1;
	}

	for (let [word, count] of Object.entries(frequency)) {
		console.log(`${word} => ${count}`);
	}
}

const input = "Four One two two three Three three four  four   four";
wordFrequency(input);