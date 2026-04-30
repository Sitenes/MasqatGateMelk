// Mobile Menu Toggle
const menuToggle = document.querySelector('.menu-toggle');
const navbar = document.querySelector('.navbar');

if (menuToggle) {
    menuToggle.addEventListener('click', () => {
        menuToggle.classList.toggle('active');
        navbar.classList.toggle('active');
    });

    // Close menu when a link is clicked
    document.querySelectorAll('.nav-links a').forEach(link => {
        link.addEventListener('click', () => {
            menuToggle.classList.remove('active');
            navbar.classList.remove('active');
        });
    });
}

// Smooth scroll behavior for navigation links
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        const target = document.querySelector(this.getAttribute('href'));
        if (target) {
            target.scrollIntoView({
                behavior: 'smooth'
            });
        }
    });
});

// Add click handlers for consultation buttons
const consultationButtons = document.querySelectorAll('.cta-btn');
consultationButtons.forEach(button => {
    button.addEventListener('click', (e) => {
        e.preventDefault();
        showConsultationModal();
    });
});

// Service button handlers
const serviceButtons = document.querySelectorAll('.service-btn');
serviceButtons.forEach(button => {
    button.addEventListener('click', (e) => {
        e.preventDefault();
        const serviceTitle = button.closest('.service-card').querySelector('h3').textContent;
        alert('Browsing: ' + serviceTitle + '\n\nProperty listing page would load here.');
    });
});

// Add scroll animation for elements
const observerOptions = {
    threshold: 0.1,
    rootMargin: '0px 0px -50px 0px'
};

const observer = new IntersectionObserver((entries) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.style.opacity = '1';
            entry.target.style.transform = 'translateY(0)';
        }
    });
}, observerOptions);

// Observe cards for animation
document.querySelectorAll('.service-card, .stat-card, .testimonial-card, .partner-badge').forEach(element => {
    element.style.opacity = '0';
    element.style.transform = 'translateY(20px)';
    element.style.transition = 'opacity 0.6s ease, transform 0.6s ease';
    observer.observe(element);
});

// Consultation modal
function showConsultationModal() {
    const modal = document.createElement('div');
    modal.className = 'modal';
    modal.innerHTML = `
        <div class="modal-content">
            <span class="close-btn">&times;</span>
            <h3>Get Free Consultation</h3>
            <form class="consultation-form">
                <input type="text" placeholder="Your Name" required>
                <input type="email" placeholder="Your Email" required>
                <input type="tel" placeholder="Your Phone" required>
                <textarea placeholder="Tell us about your property needs..." rows="4" required></textarea>
                <button type="submit" class="btn btn-primary" style="width: 100%;">Submit</button>
            </form>
        </div>
    `;
    document.body.appendChild(modal);

    // Style modal
    modal.style.cssText = `
        position: fixed;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        background: rgba(0, 0, 0, 0.5);
        display: flex;
        align-items: center;
        justify-content: center;
        z-index: 1000;
        animation: fadeIn 0.3s ease;
    `;

    const modalContent = modal.querySelector('.modal-content');
    modalContent.style.cssText = `
        background: white;
        padding: 2rem;
        border-radius: 8px;
        max-width: 500px;
        width: 90%;
        position: relative;
        box-shadow: 0 20px 60px rgba(0, 0, 0, 0.3);
        animation: slideUp 0.3s ease;
    `;

    const closeBtn = modal.querySelector('.close-btn');
    closeBtn.style.cssText = `
        position: absolute;
        top: 1rem;
        right: 1rem;
        font-size: 1.5rem;
        cursor: pointer;
        background: none;
        border: none;
        color: #6b7280;
        transition: color 0.3s ease;
    `;

    closeBtn.addEventListener('mouseover', () => {
        closeBtn.style.color = '#1f2937';
    });

    closeBtn.addEventListener('mouseout', () => {
        closeBtn.style.color = '#6b7280';
    });

    // Close modal handlers
    closeBtn.addEventListener('click', () => modal.remove());
    modal.addEventListener('click', (e) => {
        if (e.target === modal) modal.remove();
    });

    // Form submission
    const form = modal.querySelector('.consultation-form');
    form.addEventListener('submit', (e) => {
        e.preventDefault();
        alert('Thank you for your interest!\nWe will contact you soon.');
        modal.remove();
    });

    // Style form inputs
    const inputs = form.querySelectorAll('input, textarea');
    inputs.forEach(input => {
        input.style.cssText = `
            width: 100%;
            padding: 12px;
            margin-bottom: 1rem;
            border: 1px solid #e5e7eb;
            border-radius: 6px;
            font-family: inherit;
            font-size: 1rem;
            transition: border-color 0.3s ease, box-shadow 0.3s ease;
        `;

        input.addEventListener('focus', () => {
            input.style.borderColor = '#1e40af';
            input.style.boxShadow = '0 0 0 3px rgba(30, 64, 175, 0.1)';
        });

        input.addEventListener('blur', () => {
            input.style.borderColor = '#e5e7eb';
            input.style.boxShadow = 'none';
        });
    });

    // Add animations to document if not already present
    if (!document.querySelector('style[data-animations]')) {
        const style = document.createElement('style');
        style.setAttribute('data-animations', 'true');
        style.textContent = `
            @keyframes fadeIn {
                from { opacity: 0; }
                to { opacity: 1; }
            }
            @keyframes slideUp {
                from { 
                    opacity: 0;
                    transform: translateY(20px);
                }
                to { 
                    opacity: 1;
                    transform: translateY(0);
                }
            }
        `;
        document.head.appendChild(style);
    }
}

// Header scroll effect
let lastScrollTop = 0;
const header = document.querySelector('.header');

window.addEventListener('scroll', () => {
    let scrollTop = window.pageYOffset || document.documentElement.scrollTop;
    
    if (scrollTop > 100) {
        header.style.boxShadow = '0 4px 12px rgba(0, 0, 0, 0.15)';
    } else {
        header.style.boxShadow = '0 1px 3px rgba(0, 0, 0, 0.1)';
    }
    
    lastScrollTop = scrollTop;
});

console.log('Muscat Gates website loaded successfully!');

