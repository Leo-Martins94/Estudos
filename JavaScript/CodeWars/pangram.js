var alf = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'w', 'y', 'z'];
 var result = "false";
function isPangram(string){
    var paragram = string;
    for (let i = 0; i <= paragram.length; i++) {
      var paragramForm = paragram.toLowerCase();
      if(paragramForm.includes('a') && 
        paragramForm.includes('b')&&
        paragramForm.includes('c')&&
        paragramForm.includes('d')&&
        paragramForm.includes('e')&&
        paragramForm.includes('f')&&
        paragramForm.includes('g')&&
        paragramForm.includes('h')&&
        paragramForm.includes('i')&&
        paragramForm.includes('j')&&
        paragramForm.includes('k')&&
        paragramForm.includes('l')&&
        paragramForm.includes('m')&&
        paragramForm.includes('n')&&
        paragramForm.includes('o')&&
        paragramForm.includes('p')&&
        paragramForm.includes('q')&&
        paragramForm.includes('r')&&
        paragramForm.includes('s')&&
        paragramForm.includes('t')&&
        paragramForm.includes('u')&&
        paragramForm.includes('v')&&
        paragramForm.includes('x')&&
        paragramForm.includes('y')&&
        paragramForm.includes('w')&&
        paragramForm.includes('z')){
         result = true;
      } else{
        result = false;
      }

  return result;
}};

console.log(isPangram("The quick brown fox jumps over the lazy dog"))