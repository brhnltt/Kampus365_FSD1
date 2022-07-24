import {useState} from 'react';

function UsingState() {
    const [ad, setAd] = useState("Murat");
    const [soyad, setSoyad] = useState("Başeren");

    return (
        <>
            <h2>Using State</h2>
            <hr />
            <div>
                {ad} {soyad}
            </div>
            <button onClick={() => setAd("Kadir Murat")}>Change Name</button>
            <button onClick={() => setSoyad("BAŞEREN")}>Change Surname</button>
        </>
    );
}

export default UsingState;