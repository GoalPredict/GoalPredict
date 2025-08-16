/* Reset default margins */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  background: linear-gradient(180deg, #0d0d0d, #1a1a1a); /* dark gradient background */
  color: #fff;
  font-family: Arial, Helvetica, sans-serif;
  text-align: center;
  line-height: 1.6;
}

/* Header section */
header {
  padding: 20px;
}

header .logo {
  max-width: 150px; /* size of logo */
  margin-bottom: 10px;
}

header h1 {
  font-size: 2rem;
  color: #facc15; /* gold */
}

header h2 {
  font-size: 1.5rem;
  color: #38bdf8; /* light blue */
  margin-top: 5px;
}

/* Offer section */
.offer {
  margin: 20px auto;
  padding: 20px;
}

.offer .banner {
  max-width: 100%;
  height: auto;
  border-radius: 12px;
  box-shadow: 0 4px 10px rgba(0,0,0,0.5);
  margin-bottom: 15px;
}

.offer p {
  font-size: 1.2rem;
  margin: 15px 0;
}

/* Countdown timer */
.timer {
  font-size: 1.5rem;
  font-weight: bold;
  color: #f87171; /* red */
}

/* CTA button */
.cta-btn {
  display: inline-block;
  background: #22c55e; /* green */
  color: white;
  padding: 12px 25px;
  font-size: 1.2rem;
  font-weight: bold;
  text-decoration: none;
  border-radius: 8px;
  transition: background 0.3s ease;
}

.cta-btn:hover {
  background: #16a34a; /* darker green */
}

/* Footer */
footer {
  background: #111;
  padding: 15px;
  margin-top: 40px;
  font-size: 0.9rem;
  color: #aaa;
}
