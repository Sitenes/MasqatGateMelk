# PropertyGates - Real Estate Website

A modern, responsive real estate marketplace website similar to muscatgates.com.

## Features

✨ **Key Features:**
- **Responsive Design** - Works perfectly on desktop, tablet, and mobile devices
- **Modern Hero Section** - Eye-catching banner with call-to-action
- **Property Search** - Filter properties by location, type, and price range
- **Featured Properties** - Display property listings with detailed information
- **Partner Showcase** - Highlight real estate agencies and developers
- **About Section** - Company information with key benefits
- **Consultation Modal** - Interactive form for customer inquiries
- **Footer** - Complete footer with links and social media
- **Smooth Animations** - Scroll animations and hover effects

## Files Included

1. **index.html** - Main HTML structure
2. **styles.css** - Complete styling with responsive design
3. **script.js** - Interactive features and functionality

## How to Use

### Option 1: Open in Browser
Simply double-click `index.html` to open it in your default browser.

### Option 2: Use a Local Server
For better performance, run a local server:

**Python 3:**
```bash
python -m http.server 8000
```

**Python 2:**
```bash
python -m SimpleHTTPServer 8000
```

**Node.js (with http-server):**
```bash
npx http-server
```

Then visit `http://localhost:8000` in your browser.

## Customization

### Colors
Edit the CSS variables in `styles.css`:
```css
:root {
    --primary-color: #1e40af;      /* Blue */
    --secondary-color: #0f766e;    /* Teal */
    --accent-color: #f59e0b;       /* Amber */
    /* ... more colors */
}
```

### Content
- Update company name in `index.html` (PropertyGates)
- Modify property listings in the "Featured Properties" section
- Add real developer/partner logos
- Update contact information in the footer

### Partner Logos
Replace placeholder logo divs with actual images:
```html
<!-- Old -->
<div class="logo-placeholder">Developer 1</div>

<!-- New -->
<img src="path/to/logo.png" alt="Developer Name">
```

## Sections

1. **Header/Navigation** - Sticky navigation bar with logo and menu
2. **Hero Section** - Main banner with headline and CTA button
3. **Search Section** - Property search form with filters
4. **Featured Properties** - Property cards with details and pricing
5. **Partners Section** - Showcase of real estate partners
6. **About Section** - Company information and benefits
7. **CTA Section** - Call-to-action for consultations
8. **Footer** - Links, contact info, and social media

## Interactive Features

- **Smooth Scrolling** - Navigation links scroll smoothly to sections
- **Consultation Modal** - Click "Get Consultation" to open contact form
- **Scroll Animations** - Cards animate in as you scroll
- **Responsive Navigation** - Mobile-friendly menu
- **Form Validation** - Consultation form with required fields

## Browser Support

- Chrome/Edge (latest)
- Firefox (latest)
- Safari (latest)
- Mobile browsers (iOS Safari, Chrome Mobile)

## Next Steps

To enhance this website further:

1. **Add a Backend** - Connect to a database for real property listings
2. **Property Details Page** - Create individual pages for each property
3. **Image Gallery** - Add property photo galleries
4. **User Accounts** - Implement user authentication and saved properties
5. **Map Integration** - Add Google Maps for property locations
6. **Email Integration** - Connect consultation form to email service
7. **SEO Optimization** - Add meta tags and structured data
8. **Performance** - Optimize images and lazy load content

## License

Free to use and modify. Customize as needed for your real estate business!
