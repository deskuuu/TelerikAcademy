let addScroll = false,
    userAgentString=navigator.userAgent;

if ((userAgentString.indexOf('MSIE 5') > 0) || (userAgentString.indexOf('MSIE 6')) > 0) {
    addScroll = true;
}

let b = navigator.appName,
    off = 0,
    txt = "",
    pX = 0,
    pY = 0;

document.on(onmousemove) = mouseMove;

let netscapeCondition = (b == "Netscape");

function mouseMove(evn) {
    if (netscapeCondition) {
        document.captureEvents(Event.MOUSEMOVE);

        if (document.layers['ToolTip'].visibility == 'show') {
            PopTip();
        } else {
            if (document.all['ToolTip'].style.visibility == 'visible') {
                PopTip();
            }
        }
        
        pX = evn.pageX - 5;
        pY = evn.pageY;
    } else {
        pX = event.x - 5;
        pY = event.y;
    }
}

function PopTip() {
    if (netscapeCondition) {
        theLayer = eval('document.layers[\'ToolTip\']'); // Eval is bad
        let innerWidth=window.innerWidth;
           
        if ((pX + 120) > innerWidth) {
            pX = innerWidth - 150;
        }

        theLayer.left = pX + 10;
        theLayer.top = pY + 15;
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'ToolTip\']');

        if (theLayer) {
            pX = event.x - 5;
            pY = event.y;

            if (addScroll) {
                pX = pX + document.body.scrollLeft;
                pY = pY + document.body.scrollTop;
            }

            if ((pX + 120) > document.body.clientWidth) {
                pX = pX - 150;
            }

            theLayer.style.pixelLeft = pX + 10;
            theLayer.style.pixelTop = pY + 15;
            theLayer.style.visibility = 'visible';
        }
    }
}

function HideTip() {
    args = HideTip.arguments;

    if (netscapeCondition) {
        document.layers['ToolTip'].visibility = 'hide';
    } else {
        document.all['ToolTip'].style.visibility = 'hidden';
    }
}

function HideMenu1() {
    if (netscapeCondition) {
        document.layers['menu1'].visibility = 'hide';
    } else {
        document.all['menu1'].style.visibility = 'hidden';
    }
}

function ShowMenu1() {
    if (netscapeCondition) {
        theLayer = eval('document.layers[\'menu1\']');
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'menu1\']');
        theLayer.style.visibility = 'visible';
    }
}

function HideMenu2() {
    if (netscapeCondition) {
        document.layers['menu2'].visibility = 'hide';
    } else {
        document.all['menu2'].style.visibility = 'hidden';
    }
}

function ShowMenu2() {
    if (netscapeCondition) {
        theLayer = eval('document.layers[\'menu2\']');
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'menu2\']');
        theLayer.style.visibility = 'visible';
    }
}