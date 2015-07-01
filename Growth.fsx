//using f# code for prototype part of the experiment

//-17.6 < x0 < +INF

//find corner cases 
//let root = (System.Math.Pow(930.0, 0.5)) - 30.0;;
//let root = -(System.Math.Pow(930.0, 0.5)) - 30.0;;
//let x = -60.49590136;
//let x = 0.495901364;
//let y = -1250.0;

//let root = (System.Math.Pow(830.0, 0.5)) - 30.0;;
//let root = -(System.Math.Pow(830.0, 0.5)) - 30.0;;
//let x = -58.80972058;
//let x = -1.190279418;
//let y = -1250.0;

let r (x:float) = 
    System.Math.Round (x*4.0, System.MidpointRounding.ToEven)/4.0;

let x = 1.0;
let y = 5062.5;

let f x = ((0.5 * x * x) + (30.0 * x) + 10.0) / 25.0;;

let x0 = f x;

let growth y x0 = y / (x0 * 1250.0);;

let g = growth y x0;;

let x1 = g*x0;;

let x2 = x1*x0;;

let x3 = x2*x0;;

let x4 = x3*x0;;

printfn "first number %f" x0
printfn "growth %f" g
printfn "%f %f %f %f %f" (r x0) (r x1) (r x2) (r x3) (r x4);;
