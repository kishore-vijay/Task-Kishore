function sendFormData(formData) {
    var xhr = new XMLHttpRequest();
    xhr.open('POST', 'http://localhost:5152/api/Book/addbook', true);
    
    xhr.onreadystatechange = function () {
      if (xhr.readyState == 4) {
        if (xhr.status == 200) {
          console.log('Book added successfully.');
        } else {
          console.error('Error adding book:', xhr.statusText);
        }
      }
    };
    
    xhr.send(formData);
  }
  