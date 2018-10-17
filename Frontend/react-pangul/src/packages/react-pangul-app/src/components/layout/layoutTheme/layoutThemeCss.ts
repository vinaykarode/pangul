const styles = `
/** Font related global styles */
@import url('https://fonts.googleapis.com/css?family=Roboto');

html, body {
    font-family: 'Roboto', sans-serif;
    font-size: 4mm;
}

/** Component styles */
.component--LayoutTheme {
    padding: 0;
    margin: 0;
}

html, body {
    padding: 0;
    margin: 0;
}

/** Headers */
h1, h2, h3, h4, h5, h6 {
    margin: 0;
    padding: 0;
    text-shadow: 2px 2px #efefef;
}

h1 {
    font-size: 2em;
}

h2 {
    font-size: 1.8em;
}

h3 {
    font-size: 1.6em;
}

h4 {
    font-size: 1.4em;
}

h5 {
    font-size: 1.2em;
}

h6 {
    font-size: 1em;
}

/** Margins and paragraphs */
p {
    margin: 0.2em 0;
}

/** Form related global styles */
form fieldset {
    border: 0;
    margin: 0.2em;
    padding: 0;
    position: relative;
    text-align: center;
}

form fieldset input {
    display: inline-block;
    width: calc(100% - 1.4em);
    font-size: 1em;
    line-height: 1.5em;
    height: 1.5em;
    margin: 0;
    padding: 0.2em 0.5em;
    border: thin solid #e0e0e0;
}

form button {
    font-size: 1em;
    padding: 0.2em 0.5em;
    border: thin solid #e0e0e0;
    border-radius: 2px;
}

form .buttons {
    text-align: right;
}

form textarea {
    width: calc(100% - 1.4em);
    font-size: 1em;
    margin: 0;
    border: thin solid #e0e0e0;
    padding: 0.2em 0.5em;
}

/** Link related globals */
a {
    color: #00008a;
    text-decoration: none;
}

a:visited {
    color: #00008a;
}

a:hover {
    color: #00008a;
    text-decoration: none !important;
}
`;

export default styles;