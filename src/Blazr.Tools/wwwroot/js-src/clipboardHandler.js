export function copyText(text) {
    var blazrToolsClipTextArea = document.createElement("textarea");
    blazrToolsClipTextArea.style.top = "0";
    blazrToolsClipTextArea.style.left = "0";
    blazrToolsClipTextArea.style.position = "fixed";
    blazrToolsClipTextArea.value = text;
    document.body.appendChild(blazrToolsClipTextArea);
    blazrToolsClipTextArea.focus();
    blazrToolsClipTextArea.select();
    try {
        document.execCommand('copy');
        return {
            Succeeded: true,
            Error: ""
        };
    } catch (e) {
        return {
            Succeeded: true,
            Error: e
        };
    }
    finally {
        document.body.removeChild(blazrToolsClipTextArea);
    }
}