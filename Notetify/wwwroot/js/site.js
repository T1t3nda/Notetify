document.addEventListener('DOMContentLoaded', function () {
    var textarea = document.querySelector('.dynamic-textarea');

    // Function to adjust the textarea height
    function adjustHeight() {
        this.style.height = 'auto'; // Reset the height
        this.style.height = this.scrollHeight + 'px'; // Set the new height
    }

    // Adjust the height on input
    textarea.addEventListener('input', adjustHeight);

    // Adjust the height when the page loads
    adjustHeight.call(textarea);


});