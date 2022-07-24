import { useState } from 'react';

function UsingStateObject() {
    const [kisi, setKisi] = useState({ ad: "Murat", soyad: "Başeren", yas: 30 });

    return (
        <>
            <h2>Using State Object</h2>
            <hr />
            <div>{kisi.ad}</div>
            <div>{kisi.soyad}</div>
            <div>{kisi.yas}</div>
            <br />
            <br />
            <button onClick={() => setKisi({ ...kisi, ad: "Kadir Murat" })}>Ad Değiştir</button>
            <button onClick={() => setKisi({ ...kisi, ad: "Kadir Murat", soyad: "BAŞEREN", yas: 33 })}>Hepsini Değiştir</button>
        </>
    );
}

export default UsingStateObject;