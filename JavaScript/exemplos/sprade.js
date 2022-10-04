const arr = [0,1,5]
const newArr = [...arr, 3, 25]

function soma(a,b,c,d){
    return a+b+c+d
}

console.log(soma(1,...arr));