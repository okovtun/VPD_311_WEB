// JavaScript source code
function Power()
{
    let base = document.getElementById("base").value;
    let exponent = document.getElementById("exponent").value;
    document.getElementById("power").innerHTML = base ** exponent;
}
document.addEventListener("mousemove", GetMouseCoords);
function GetMouseCoords(event)
{
    let x = event.clientX;
    let y = event.clientY;
    document.getElementById("mouse").innerHTML = `X = ${x}, Y = ${y}`;
}
function SwitchBackground()
{
    let switchBackground = document.getElementById("switch-background");
    if(switchBackground.style.backgroundImage === 'url("img/moon.png")')
    {
        switchBackground.style.backgroundImage = 'url("img/sun.png")';
    }
    else
    {
        switchBackground.style.backgroundImage = 'url("img/moon.png")';
    }
}