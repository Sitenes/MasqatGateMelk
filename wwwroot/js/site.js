/**
 * Muscat Gates - Professional Smooth Animations
 * Vanilla ES6 JavaScript
 */

document.addEventListener('DOMContentLoaded', () => {
    document.body.classList.add('loaded');
    initScrollReveal();
    initCounterAnimation();
    initStickyNavbar();
    initParallax();
    initScrollSpy();
    initHeroAnimations();
    initButtonEffects();
    initSmoothScrolling();
    initImageLazyEffects();
});

/**
 * Reveal elements when they enter the viewport
 */
function initScrollReveal() {
    const revealElements = document.querySelectorAll('.service-card, .testimonial-card, .agent-card, .blog-card, .section-title, .eyebrow, .stat-box');
    
    revealElements.forEach(el => el.classList.add('reveal'));

    const observerOptions = {
        threshold: 0.15,
        rootMargin: '0px 0px -50px 0px'
    };

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('active');
                observer.unobserve(entry.target);
            }
        });
    }, observerOptions);

    revealElements.forEach(el => observer.observe(el));
}

/**
 * Animate numbers from 0 to target value
 */
function initCounterAnimation() {
    const stats = document.querySelectorAll('.stat-value');
    
    const animateCounter = (el) => {
        const textValue = el.innerText.trim();
        const target = parseFloat(textValue.replace(/[^0-9.]/g, ''));
        const suffix = textValue.replace(/[0-9.]/g, '');
        const duration = 2000;
        const startTime = performance.now();
        
        const update = (now) => {
            const elapsed = now - startTime;
            const progress = Math.min(elapsed / duration, 1);
            const easeOutQuad = t => t * (2 - t);
            const current = progress === 1 ? target : target * easeOutQuad(progress);
            
            if (target % 1 === 0) {
                el.innerText = Math.floor(current) + suffix;
            } else {
                el.innerText = current.toFixed(1) + suffix;
            }

            if (progress < 1) {
                requestAnimationFrame(update);
            }
        };
        
        requestAnimationFrame(update);
    };

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                animateCounter(entry.target);
                observer.unobserve(entry.target);
            }
        });
    }, { threshold: 0.5 });

    stats.forEach(stat => observer.observe(stat));
}

/**
 * Handle sticky navbar behavior (hide on scroll down, show on up)
 */
function initStickyNavbar() {
    const nav = document.querySelector('.navbar');
    if (!nav) return;
    let lastScroll = 0;

    window.addEventListener('scroll', () => {
        const currentScroll = window.pageYOffset;

        if (currentScroll <= 0) {
            nav.classList.remove('scrolled');
            return;
        }

        if (currentScroll > 100) {
            nav.classList.add('scrolled');
        } else {
            nav.classList.remove('scrolled');
        }

        if (currentScroll > lastScroll && currentScroll > 500 && !nav.classList.contains('nav-hidden')) {
            nav.classList.add('nav-hidden');
        } else if (currentScroll < lastScroll && nav.classList.contains('nav-hidden')) {
            nav.classList.remove('nav-hidden');
        }

        lastScroll = currentScroll;
    }, { passive: true });
}

/**
 * Subtle parallax effect for hero background
 */
function initParallax() {
    const heroImage = document.querySelector('.hero-image-panel');
    if (!heroImage) return;

    window.addEventListener('scroll', () => {
        const scroll = window.pageYOffset;
        if (scroll < 1000) {
            heroImage.style.backgroundPositionY = `${scroll * 0.4}px`;
        }
    }, { passive: true });
}

/**
 * Update active link in navbar based on scroll position
 */
function initScrollSpy() {
    const sections = document.querySelectorAll('section[id], footer[id]');
    const navLinks = document.querySelectorAll('.nav-link');

    window.addEventListener('scroll', () => {
        let current = '';
        sections.forEach(section => {
            const sectionTop = section.offsetTop;
            const sectionHeight = section.clientHeight;
            if (window.pageYOffset >= (sectionTop - 250)) {
                current = section.getAttribute('id');
            }
        });

        navLinks.forEach(link => {
            link.classList.remove('active');
            const href = link.getAttribute('href');
            if (href && href.startsWith('#') && href.substring(1) === current) {
                link.classList.add('active');
            }
        });
    }, { passive: true });
}

/**
 * Sequential entrance for hero content
 */
function initHeroAnimations() {
    const heroElements = document.querySelectorAll('.hero-wrap h1, .hero-wrap p, .hero-wrap .btn, .hero-partners-card');
    heroElements.forEach((el, index) => {
        el.style.opacity = '0';
        el.style.transform = 'translateY(20px)';
        el.style.transition = 'all 0.8s cubic-bezier(0.165, 0.84, 0.44, 1)';
        
        setTimeout(() => {
            el.style.opacity = '1';
            el.style.transform = 'translateY(0)';
        }, 200 + (index * 150));
    });
}

/**
 * Ripple effect and other button interactions
 */
function initButtonEffects() {
    document.querySelectorAll('.btn').forEach(button => {
        button.addEventListener('click', function(e) {
            const circle = document.createElement('span');
            const diameter = Math.max(this.clientWidth, this.clientHeight);
            const radius = diameter / 2;
            const rect = this.getBoundingClientRect();

            circle.style.width = circle.style.height = `${diameter}px`;
            circle.style.left = `${e.clientX - rect.left - radius}px`;
            circle.style.top = `${e.clientY - rect.top - radius}px`;
            circle.classList.add('ripple');

            const ripple = this.getElementsByClassName('ripple')[0];
            if (ripple) ripple.remove();

            this.appendChild(circle);
        });
    });
}

/**
 * Improved smooth scroll for anchor links
 */
function initSmoothScrolling() {
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function(e) {
            const targetId = this.getAttribute('href');
            if (targetId === '#' || !targetId.startsWith('#')) return;
            
            const targetElement = document.querySelector(targetId);
            if (targetElement) {
                e.preventDefault();
                const nav = document.querySelector('.navbar');
                const navHeight = nav ? nav.offsetHeight : 0;
                const targetPosition = targetElement.getBoundingClientRect().top + window.pageYOffset - navHeight;
                
                window.scrollTo({
                    top: targetPosition,
                    behavior: 'smooth'
                });

                // Update URL hash without jumping
                history.pushState(null, null, targetId);
            }
        });
    });
}

/**
 * Image zoom-in effect when they become visible
 */
function initImageLazyEffects() {
    const images = document.querySelectorAll('.service-image, .blog-image, .testimonial-photo, .agent-avatar, .partner-mark img');
    
    const imageObserver = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.style.transition = 'transform 1.2s cubic-bezier(0.165, 0.84, 0.44, 1), opacity 1.2s ease';
                entry.target.style.opacity = '1';
                imageObserver.unobserve(entry.target);
            }
        });
    }, { threshold: 0.1 });

    images.forEach(img => {
        img.style.opacity = '0';
        imageObserver.observe(img);
    });
}

