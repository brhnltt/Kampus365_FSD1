import { useState, useEffect } from "react";

function UsingUseEffect() {
    const [number, setNumber] = useState(10);
    const [text, setText] = useState("Lorem");

    useEffect(() => {
        console.log("Component mount (DOM - HTML 'e eklendi) oldu.");

        return () => console.log("Component unmount oldu.");

    }, []);

    // useEffect(() => {
    //     console.log("Herhangi bir state değiştiğinde çalış.");
    // });

    // useEffect(() => {
    //     console.log("Number ve Text 'in state'i değişince çalış.");
    // },[number, text]);

    return (
        <>
            <div>
                <h1>Using Use Effect</h1>
                <hr />
            </div>

            <div>
                <h2>{number}</h2>
                <button onClick={() => setNumber(number + 1)}>Arttır</button>
            </div>
            <br />
            <br />
            <div>
                <h2>{text}</h2>
                <input type="text" placeholder="new text value" value={text} onChange={(e) => setText(e.target.value)} />
            </div>
        </>
    );
}

export default UsingUseEffect;