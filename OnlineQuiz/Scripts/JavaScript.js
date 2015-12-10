window.onload = function validate() {
    var arr = document.getElementsByTagName('div');
    for (var i = 0; i < arr.length; i++) {
        if (arr[i].id == 'answer3' && arr[i].innerText == '3.  ') {
            arr[i].style.visibility = 'hidden';
        }
    }


}