document.addEventListener('DOMContentLoaded', function () {
  function addBook(event) {
    event.preventDefault();

    var formData = new FormData();
    formData.append('bookTitle', document.getElementById('bookTitle').value);
    formData.append('bookAuthor', document.getElementById('bookAuthor').value);
    formData.append('bookDescription', document.getElementById('bookDescription').value);
    formData.append('bookLanguage', document.getElementById('bookLanguage').value);
    formData.append('bookGenre', document.getElementById('bookGenre').value);
    formData.append('bookPrice', document.getElementById('bookPrice').value);
    formData.append('bookPublisher', document.getElementById('bookPublisher').value);

    // Call the AJAX function to post data
    sendFormData(formData);
  }

  document.getElementById('bookForm').addEventListener('submit', addBook);
});
