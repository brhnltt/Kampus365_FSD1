import { useState } from 'react';

function UsingStateInput() {
    const [kisi, setKisi] = useState({ ad: "Murat", soyad: "Başeren", yas: 30 });

    // const onChangeAd = (e) => setKisi({ ...kisi, ad: e.target.value });

    // return (
    //     <>
    //         <h2>Using State Input</h2>
    //         <hr />
    //         <div>{kisi.ad}</div>
    //         <div>{kisi.soyad}</div>
    //         <div>{kisi.yas}</div>
    //         <br />
    //         <br />
    //         <input type="text" placeholder="ad" value={kisi.ad} onChange={onChangeAd} />
    //         <input type="text" placeholder="soyad" value={kisi.soyad} onChange={(e) => setKisi({ ...kisi, soyad: e.target.value })} />
    //         <input type="number" placeholder="yas" value={kisi.yas} onChange={(e) => setKisi({ ...kisi, yas: e.target.value })} />
    //     </>
    // );

    const onChangeValue = (e) => setKisi({ ...kisi, [e.target.name]: e.target.value });

    return (
        <>
            <h2>Using State Input</h2>
            <hr />
            <div>{kisi.ad}</div>
            <div>{kisi.soyad}</div>
            <div>{kisi.yas}</div>
            <br />
            <br />
            <input name="ad" type="text" placeholder="ad" value={kisi.ad} onChange={onChangeValue} />
            <input name="soyad" type="text" placeholder="soyad" value={kisi.soyad} onChange={onChangeValue} />
            <input name="yas" type="number" placeholder="yas" value={kisi.yas} onChange={onChangeValue} />
        </>
    );
}

export default UsingStateInput;