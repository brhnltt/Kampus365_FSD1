import {useState} from 'react';

function UsingStateArray() {
    const [sehirler, setSehirler] = useState(["İstanbul","Antalya","İzmir","Balıkesir"]);

    return (
        <>
            <h2>Using State Array</h2>
            <hr />
            <div>
                <ul>
                    {
                        sehirler.map((sehir, i) => <li key={i}>{sehir}</li>)
                    }
                </ul>
            </div>
            <button onClick={() => setSehirler([...sehirler, "Mersin"]) }>Yeni şehir ekle</button>
        </>
    );
}

export default UsingStateArray;